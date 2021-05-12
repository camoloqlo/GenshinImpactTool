using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Configuration.ConfigurationManager;

namespace GenshinImpactTool
{
    public partial class frmDashboard : Form
    {
        CultureInfo ci = new CultureInfo("Es-Es");
        Configuration config = OpenExeConfiguration(ConfigurationUserLevel.None);
        public frmDashboard()
        {
            InitializeComponent();
            
            loadResin();
            loadSchedule(ci.DateTimeFormat.GetDayName(DateTime.Now.AddHours(-4).DayOfWeek));
        }

        public class Personaje
        {
            string nombre;
            Image libroTalento;
            string dias;
            Image logo;

            public string Nombre { get => nombre; set => nombre = value; }

            public string Dias { get => dias; set => dias = value; }
            public Image Logo { get => logo; set => logo = value; }
            public Image LibroTalento { get => libroTalento; set => libroTalento = value; }
        }

        private void loadResin()
        {
           
            DateTime FechaHoraInicio = DateTime.Parse(config.AppSettings.Settings["timeSetResin"].Value);
            TimeSpan diferencia = DateTime.Now - FechaHoraInicio;
            var diferenciaenminutos = diferencia.TotalMinutes;

            // int currentResin = Int32.Parse(config.AppSettings.Settings["currentResin"].Value);
            int maxResin = Int32.Parse(config.AppSettings.Settings["maxResin"].Value);
            int currResin = Int32.Parse(config.AppSettings.Settings["setResin"].Value) + (Convert.ToInt32(diferenciaenminutos / Int32.Parse(config.AppSettings.Settings["refreshInterval"].Value)));
            if (currResin >= maxResin)
            {
                lbCurrentResin.Text = maxResin + "/" + maxResin;
            }
            else if (currResin < 0)
            {

                lbCurrentResin.Text = 0 + "/" + maxResin;
            }
            else
            {
                lbCurrentResin.Text = currResin + "/" + maxResin;
            }

            int minutos = (maxResin - currResin) * 8;
            int hor, min;
            hor = minutos / 60;
            min = minutos % 60;

            if (minutos > 0)
            {
                lbResinInfo.Text = "Resina al maximo aproximadamente el " + FechaHoraInicio.AddHours(hor).AddMinutes(min).Date.Day + " de " + FechaHoraInicio.AddHours(hor).AddMinutes(min).ToString("MMMM") + " a las " + DateTime.Now.AddHours(hor).AddMinutes(min).ToString("HH:mm") + " (" + (hor < 10 ? "0" + hor : hor + "") + " hora(s) y " + (min < 10 ? "0" + min : min + "") + " minuto(s))";
            }
            else
            {
                lbResinInfo.Text = "Tu resina esta llena hace aproximadamente " + Math.Abs(hor) + " hora(s) y " + Math.Abs(min) + " minuto(s) ";
            }
        }
        private void loadSchedule(string dia)
        {
            List<Personaje> ListaPersonajes = new List<Personaje>
            {
                new Personaje{Nombre="Amber", LibroTalento=Properties.Resources.Freedom,Dias="Lunes Jueves",Logo=Properties.Resources.Amber },
                new Personaje{Nombre="Barbara", LibroTalento=Properties.Resources.Freedom ,Dias="Lunes Jueves",Logo=Properties.Resources.Barbara },
                new Personaje{Nombre="Diona", LibroTalento=Properties.Resources.Freedom ,Dias="Lunes Jueves",Logo=Properties.Resources.Diona },
                new Personaje{Nombre="Klee", LibroTalento=Properties.Resources.Freedom ,Dias="Lunes Jueves" ,Logo=Properties.Resources.Klee},
                new Personaje{Nombre="Sacarosa", LibroTalento=Properties.Resources.Freedom ,Dias="Lunes Jueves",Logo=Properties.Resources.Sucrose },
                new Personaje{Nombre="Tartaglia", LibroTalento=Properties.Resources.Freedom ,Dias="Lunes Jueves",Logo=Properties.Resources.Tartaglia },
                new Personaje{Nombre="Keching", LibroTalento=Properties.Resources.Prosperity ,Dias="Lunes Jueves" ,Logo=Properties.Resources.Keqing},
                new Personaje{Nombre="Ningguang", LibroTalento=Properties.Resources.Prosperity ,Dias="Lunes Jueves" ,Logo=Properties.Resources.Ningguang},
                new Personaje{Nombre="Qiqi", LibroTalento=Properties.Resources.Prosperity ,Dias="Lunes Jueves",Logo=Properties.Resources.Qiqi },
                new Personaje{Nombre="Xiao", LibroTalento=Properties.Resources.Prosperity ,Dias="Lunes Jueves" ,Logo=Properties.Resources.Xiao},
                new Personaje{Nombre="Chongyun", LibroTalento=Properties.Resources.Diligence ,Dias="Martes Viernes" ,Logo=Properties.Resources.Chongyun},
                new Personaje{Nombre="Ganyu", LibroTalento=Properties.Resources.Diligence ,Dias="Martes Viernes" ,Logo=Properties.Resources.Ganyu},
                new Personaje{Nombre="Hu Tao", LibroTalento=Properties.Resources.Diligence ,Dias="Martes Viernes" ,Logo=Properties.Resources.Hu_Tao},
                new Personaje{Nombre="Xiangling", LibroTalento=Properties.Resources.Diligence ,Dias="Martes Viernes" ,Logo=Properties.Resources.Xiangling},
                new Personaje{Nombre="Albedo", LibroTalento=Properties.Resources.Resistance ,Dias="Martes Viernes",Logo=Properties.Resources.Albedo },
                new Personaje{Nombre="Diluc", LibroTalento=Properties.Resources.Resistance ,Dias="Martes Viernes",Logo=Properties.Resources.Diluc },
                new Personaje{Nombre="Jean", LibroTalento=Properties.Resources.Resistance ,Dias="Martes Viernes",Logo=Properties.Resources.Jean },
                new Personaje{Nombre="Mona", LibroTalento=Properties.Resources.Resistance ,Dias="Martes Viernes",Logo=Properties.Resources.Mona },
                new Personaje{Nombre="Noelle", LibroTalento=Properties.Resources.Resistance ,Dias="Martes Viernes" ,Logo=Properties.Resources.Noelle},
                new Personaje{Nombre="Razor", LibroTalento=Properties.Resources.Resistance ,Dias="Martes Viernes",Logo=Properties.Resources.Razor },
                new Personaje{Nombre="Albedo", LibroTalento=Properties.Resources.Ballad ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Albedo },
                new Personaje{Nombre="Fischl", LibroTalento=Properties.Resources.Ballad ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Fischl },
                new Personaje{Nombre="Kaeya", LibroTalento=Properties.Resources.Ballad ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Kaeya },
                new Personaje{Nombre="Lisa", LibroTalento=Properties.Resources.Ballad ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Lisa },
                new Personaje{Nombre="Rosaria", LibroTalento=Properties.Resources.Ballad ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Rosaria },
                new Personaje{Nombre="Venti", LibroTalento=Properties.Resources.Ballad ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Venti },
                new Personaje{Nombre="Beidou", LibroTalento=Properties.Resources.Gold ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Beidou },
                new Personaje{Nombre="Xingqiu", LibroTalento=Properties.Resources.Gold ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Xingqiu},
                new Personaje{Nombre="Xinyan", LibroTalento=Properties.Resources.Gold ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Xinyan },
                new Personaje{Nombre="Yanfei", LibroTalento=Properties.Resources.Gold ,Dias="Miércoles Sábado ",Logo=Properties.Resources.Yanfei },
                new Personaje{Nombre="Zhongli", LibroTalento=Properties.Resources.Gold ,Dias="Miércoles Sábado " ,Logo=Properties.Resources.Zhongli}
            };

            lbAgendaDia.Text = "Libros de Talento (" + dia + ")";
            foreach (Personaje item in ListaPersonajes)
            {
                if (item.Dias.ToLower().Contains(dia) && dia != "domingo")
                {

                    ScheduleCharacter control = new ScheduleCharacter();
                    control.lbName.Text = item.Nombre;
                    //control.imgIcon.Image = Image.FromFile("Resources//" + item.Nombre + ".png");
                    control.imgIcon.Image = item.Logo;
                    control.imgLibro.Image = item.LibroTalento;
                    panelSchedule.Controls.Add(control);
                }
                else if (dia.Equals("domingo"))
                {
                    ScheduleCharacter control = new ScheduleCharacter();
                    control.lbName.Text = item.Nombre;
                    control.imgIcon.Image = item.Logo;
                    control.imgLibro.Image = item.LibroTalento;
                    panelSchedule.Controls.Add(control);

                }



            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings["setResin"].Value = 0 + "";
            config.AppSettings.Settings["timeSetResin"].Value = DateTime.Now.ToString(); ;
            config.Save(ConfigurationSaveMode.Modified, true);
            loadResin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CambiarResina(20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambiarResina(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarResina(5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambiarResina(10);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CambiarResina(-20);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CambiarResina(-10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CambiarResina(-5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CambiarResina(-1);
        }

        private void CambiarResina(int cantidad)
        {

            if (Int32.Parse(config.AppSettings.Settings["setResin"].Value) + cantidad < 0)
            {
                config.AppSettings.Settings["setResin"].Value = 0 + "";
                config.AppSettings.Settings["timeSetResin"].Value = DateTime.Now.ToString(); ;
                config.Save(ConfigurationSaveMode.Modified, true);

            }
            else
            {
                DateTime FechaHoraInicio = DateTime.Parse(config.AppSettings.Settings["timeSetResin"].Value);
                TimeSpan diferencia = DateTime.Now - FechaHoraInicio;
                var diferenciaenminutos = diferencia.TotalMinutes;
                config.AppSettings.Settings["setResin"].Value = Int32.Parse(config.AppSettings.Settings["setResin"].Value) + (Convert.ToInt32(diferenciaenminutos / Int32.Parse(config.AppSettings.Settings["refreshInterval"].Value))) + cantidad + "";
                config.AppSettings.Settings["timeSetResin"].Value = DateTime.Now.ToString(); ;
                config.Save(ConfigurationSaveMode.Modified, true);
            }

            loadResin();
        }
    }
}
