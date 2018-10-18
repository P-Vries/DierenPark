using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DierenPark
{
    public partial class frmUI : Form
    {
        //
        //Vars
        //
        public bool IsEchtpaar;
        public bool IsPersoonlijk; 
        DateTime Nu = DateTime.Now;

        public frmUI()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //
        private int BerekenLeeftijd(DateTime geboortedatum)
        {
            var leeftijd = Nu.Year - geboortedatum.Year;
            return leeftijd;
        }

        private void Bereken()
        {
            if (IsEchtpaar)
            {
                if (txbKinderen.Text == "") { lblOut.Text = "De te betalen kost is: €61.-"; }
                if (txbKinderen.Text != "")
                {
                    int kinderAantal = int.Parse(txbKinderen.Text);
                    if (kinderAantal == 1) { lblOut.Text = "De te betalen kost is: €71.-"; }
                    else if (kinderAantal == 2) { lblOut.Text = "De te betalen kost is: €82.-"; }
                    else if (kinderAantal > 2)
                    {
                        kinderAantal = kinderAantal - 2;
                        int betaalVoorKinderen = kinderAantal * 11;
                        lblOut.Text = "De te betalen kost is: €" + (82 + betaalVoorKinderen).ToString() + ".-";
                    }
                }
                if (BerekenLeeftijd(dateTimePicker1.Value) > 65 && BerekenLeeftijd(dateTimePicker2.Value) > 65) { lblOut.Text = "De te betalen kost is: €65.-";}
            }
            if (IsPersoonlijk)
            {
                if ((BerekenLeeftijd(dateTimePicker1.Value) < 65)) { lblOut.Text = "De te betalen kost is: €30.-";}
                else if (BerekenLeeftijd(dateTimePicker2.Value) < 65) { lblOut.Text = "De te betalen kost is: €30.-"; }
                else { lblOut.Text = "De te betalen kost is: €26.-"; }
            }
            if (IsPersoonlijk || IsEchtpaar)
            {
                if (txbKinderen.Text != "")
                {
                    int kinderAantal = int.Parse(txbKinderen.Text);
                    if (kinderAantal == 1) { lblOut.Text = "De te betalen kost is: €71.-"; }
                    else if (kinderAantal == 2) { lblOut.Text = "De te betalen kost is: €82.-"; }
                    else if (kinderAantal > 2)
                    {
                        kinderAantal = kinderAantal - 2;
                        int betaalVoorKinderen = kinderAantal * 11;
                        lblOut.Text = "De te betalen kost is: €" + (82 + betaalVoorKinderen).ToString() + ".-";
                    }
                }

            }
            IsEchtpaar = false;
            IsPersoonlijk = false;
        }


        //
        //Events
        //
        private void btnBereken_Click(object sender, EventArgs e)
        {
            if (chbEchtpaar.Checked) { IsEchtpaar = true; }
            if (chbEchtpaar.Checked != true && (dateTimePicker1.Value.DayOfYear == DateTime.Now.DayOfYear || dateTimePicker2.Value.DayOfYear == DateTime.Now.DayOfYear)) { IsPersoonlijk = true; }
            Bereken();
        }

        private void frmUI_Load(object sender, EventArgs e)
        {

        }
    }
}
