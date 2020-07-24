using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///Autoverhuur
///Een autoverhuurbedrijf hanteert de volgende tarieven:
///• Voor personenauto’s: Per gereden kilometer een bedrag van € 0,20 (voor elke dag dat de auto
///verhuurd is zijn de eerste 100 km vrij). Daarnaast een bedrag van € 50,= per dag.
///• Voor personenbusjes bedraagt de kilometerprijs € 0,30 en het dagtarief € 95,=.
///De auto wordt uitgegeven met een volle tank benzine. Bij het inleveren van de auto wordt de tank
///weer volledig gevuld.
///De te ontwikkelen software moet aan de hand van de verhuurgegevens het verschuldigde bedrag
///berekenen. Het aantal dagen moet worden bepaald aan de hand van begin- en einddatum
///verhuurperiode. Je mag er vanuit gaan dat elke maand 30 dagen telt. Bij het bepalen van de kosten
///moet onderweg getankte benzine ook betrokken worden.
/// </summary>
namespace Opdracht_groen_03___Autoverhuur
{
    public partial class Form1 : Form
    {
        string transportMiddel;
        public Form1()
        {
            InitializeComponent();

            numericUpDownLiterprijs.DecimalPlaces = 2;
            numericUpDownLiterprijs.Increment = 0.01M;
            numericUpDownLiterprijs.Value = 1.45M;

            radioButtonAuto.Checked = true;
        }

        DateTime beginDatum = DateTime.Now;
        DateTime eindDatum = DateTime.Now;
        TimeSpan huurTijdSpan;
        int gehuurdeDagen;
        int dagtariefAuto = 50;
        int dagtariefBusje = 95;
        decimal dagkostenAuto = 0M;
        decimal dagkostenBusje = 0M;

        int geredenKilometers;
        int belastbareKilometers;
        int gratisKilometers;
        decimal kilometerPrijsAuto = 0.20M;
        decimal kilometerPrijsBusje = 0.3M;
        decimal kilometerKostenAuto = 0M;
        decimal kilometerKostenBusje = 0M;

        int liters;
        decimal literPrijs;
        decimal benzineKosten;



        private void radioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAuto.Checked == true)
            {
                transportMiddel = "auto";
                Debug.WriteLine("transportMiddel " + transportMiddel);
            }

        }

        private void radioButtonBusje_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBusje.Checked == true)
            {
                transportMiddel = "busje";
                Debug.WriteLine("transportMiddel " + transportMiddel);
            }
        }

        private void dateTimePickerBegin_ValueChanged(object sender, EventArgs e)
        {
            beginDatum = dateTimePickerBegin.Value;
            Debug.WriteLine("beginDatum " + beginDatum);
        }

        private void dateTimePickerEind_ValueChanged(object sender, EventArgs e)
        {
            eindDatum = dateTimePickerEind.Value;
            Debug.WriteLine("eindDatum " + eindDatum);
        }

        private void numericUpDownKilometers_ValueChanged(object sender, EventArgs e)
        {
            geredenKilometers = Convert.ToInt32(numericUpDownKilometers.Value);
            Debug.WriteLine("geredenKilometers " + geredenKilometers);
        }

        private void numericUpDownLiters_ValueChanged(object sender, EventArgs e)
        {
            liters = Convert.ToInt32(numericUpDownLiters.Value);
            Debug.WriteLine("liters " + liters);
        }

        private void numericUpDownLiterprijs_ValueChanged(object sender, EventArgs e)
        {
            literPrijs = numericUpDownLiterprijs.Value;
            Debug.WriteLine("literPrijs " + literPrijs);
        }

        private void buttonBereken_Click(object sender, EventArgs e)
        {
            huurTijdSpan = eindDatum - beginDatum;
            gehuurdeDagen = (int)huurTijdSpan.TotalDays;
            if (gehuurdeDagen == 0)
            {
                gehuurdeDagen = 1;
            }
            Debug.WriteLine("gehuurdeDagen " + gehuurdeDagen);

            benzineKosten = literPrijs * liters;
            Debug.WriteLine("benzineKosten " + benzineKosten);

            gratisKilometers = gehuurdeDagen * 100;
            belastbareKilometers = geredenKilometers - gratisKilometers;

            if (belastbareKilometers > 0)
            {
                kilometerKostenAuto = kilometerPrijsAuto * belastbareKilometers;
                Debug.WriteLine("kilometerKostenAuto " + kilometerKostenAuto);
            }

            kilometerKostenBusje = kilometerPrijsBusje * geredenKilometers;
            Debug.WriteLine("kilometerKostenBusje " + kilometerKostenBusje);

            dagkostenAuto = gehuurdeDagen * dagtariefAuto;
            Debug.WriteLine("dagkostenAuto " + dagkostenAuto);
            dagkostenBusje = gehuurdeDagen * dagtariefBusje;
            Debug.WriteLine("dagkostenBusje " + dagkostenBusje);

            if (transportMiddel == "auto")
            {
                decimal totaalBedrag = benzineKosten + kilometerKostenAuto + dagkostenAuto;
                Debug.WriteLine("totaalBedrag " + totaalBedrag);
                textBoxTotaalbedrag.Text = totaalBedrag.ToString("c", CultureInfo.CreateSpecificCulture("nl-NL"));
            }
            if (transportMiddel == "busje")
            {
                decimal totaalBedrag = benzineKosten + kilometerKostenBusje + dagkostenBusje;
                Debug.WriteLine("totaalBedrag " + totaalBedrag);
                textBoxTotaalbedrag.Text = totaalBedrag.ToString("c", CultureInfo.CreateSpecificCulture("nl-NL"));
            }


        }


    }
}
