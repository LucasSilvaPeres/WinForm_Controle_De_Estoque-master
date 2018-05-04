using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;


namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
			EfectTime();//Chama o procedimento que irá ativar o Temporizador(timer)
		}
		private bool Efect = true;//variavel lógica

		private void SplashTimer_Tick(object sender, EventArgs e)
		{

                if (Efect)
                {
                    Opacity -= 1D;//E Diminui a opacidade do form
                                  //equivale a This.Opacity = this.Opcatity - 0.01
                }
                if (Opacity == 0)
 
                {
                    Efect = false;
                    SplashTimer.Enabled = false;//Desliga o Timer
                    FrmLogin frmlogin = new FrmLogin();//Instancia um form Login
                    frmlogin.Show();//Mostra o login
                    Hide();//Oculta o formulario Splash sem tira-lo da memória
                }
		}
		private void EfectTime()
		{
			SplashTimer.Interval = 1000; //define 190 milisegundos para a atuação do timer
			SplashTimer.Tick += new EventHandler(SplashTimer_Tick);//Dispara o evento Tick
            Opacity = 1;//Define opacidade do form 100%
            SplashTimer.Enabled = true;//ativa o timer
		}
	}
}
