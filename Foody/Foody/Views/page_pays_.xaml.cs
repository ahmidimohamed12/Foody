using System;
using System.Collections.Generic;
using Foody.Model;
using Xamarin.Forms;
using System.Linq;

namespace Foody.Views
{
    public partial class page_pays_ : ContentPage
    {
        string pa = "Afrique du Sud,Algérie,Angola,Bénin,Botswana,Burkina,Burundi,Cameroun,Cap-Vert,République centrafricaine,Comores,Congo,République démocratique du Congo,Côte d'Ivoire,Djibouti,Égypte,Érythrée,Éthiopie,Gabon,Gambie,Ghana,Guinée,Guinée-Bissau,Guinée équatoriale,Kenya,Lesotho,Libéria,Libye,Madagascar,Malawi,Mali,Maroc,Maurice,Mauritanie,Mozambique,Namibie,Niger,Nigeria,Ouganda,Rwanda,Sao Tomé-et-Principe,Sénégal,Seychelles,Sierra Leone,Somalie,Soudan,Sud-Soudan,Swaziland,Tanzanie,Tchad,Togo,Tunisie,Zambie,Zimbabwe,Antigua-et-Barbuda,Argentine,Bahamas,Barbade,Belize,Bolivie,Brésil,Canada,Chili,Colombie,Costa Rica,Cuba,République dominicaine,Dominique,Équateur,États-Unis,Grenade,Guatemala,Guyana,Haïti,Honduras,Jamaïque,Mexique,Nicaragua,Panama,Paraguay,Pérou,Porto Rico,Saint-Christophe-et-Niévès,Sainte-Lucie,Saint-Vincent-et-les Grenadines,Salvador,Suriname,Trinité-et-Tobago,Uruguay,Venezuela,Afghanistan,Arabie saoudite,Bahreïn,Bangladesh,Bhoutan,Birmanie,Brunei,Cambodge,Chine,Corée du Nord,Corée du Sud,Émirats arabes unis,Inde,Indonésie,Irak,Iran,Israël,Japon,Jordanie,Kazakhstan,Kirghizistan,Koweït,Laos,Liban,Malaisie,Maldives,Mongolie,Népal,Oman,Ouzbékistan,Palestine,Pakistan,Philippines,Qatar,Singapour,Sri Lanka,Syrie,Tadjikistan,Taïwan,Thaïlande,Timor oriental,Turkménistan,Turquie,Viêt Nam,Yémen,Allemagne,Albanie,Andorre,Arménie,Autriche,Azerbaïdjan,Belgique,Biélorussie,Bosnie-Herzégovine,Bulgarie,Chypre,Croatie,Danemark,Espagne,Estonie,Finlande,France,Géorgie,Grèce,Hongrie,Irlande,Islande,Italie,Lettonie,Liechtenstein,Lituanie,Luxembourg,République de Macédoine,Malte,Moldavie,Monaco,Monténégro,Norvège,Pays-Bas,Pologne,Portugal,République tchèque,Roumanie,Royaume-Uni,Russie,Saint-Marin,Serbie,Slovaquie,Slovénie,Suède,Suisse,Ukraine,VaticanAustralie,Fidji,Kiribati,Marshall,Micronésie,Nauru,Nouvelle-Zélande,Palaos,Papouasie-Nouvelle-Guinée,Salomon,Samoa,Tonga,Tuvalu,Vanuatu";
         List<Pays> om;
        public static Pays part;
        public page_pays_()
        {
            InitializeComponent();

            var p = Plugin.XamJam.Screen.CrossScreen.Current.Size.Width;
            string[] pl = pa.Split(',');
            om = new List<Pays>();
            for (int i = 0;i<pl.Length;i++)
            {
                Pays pp = new Pays();
                pp.name_pays = pl[i];
                om.Add(pp);
            }
            var t = (from a in om
                    orderby a.name_pays ascending
                    select a).ToList();
            ls.ItemsSource = t;
            txtsr.TextChanged += textSearch_TextChanged;
            ls.ItemSelected += list_selected;

        }
        private void textSearch_TextChanged(object sender,EventArgs e)
        {
            var a = (from ol in om
                     where ol.name_pays.Contains(txtsr.Text) orderby ol.name_pays ascending
                     select ol).ToList();
            if (a == null)
            {
                ls.ItemsSource = om;
            }
            else
            {
                ls.ItemsSource = a;
            }
            
        }
        private async void list_selected(object sender,EventArgs e)
        {
            ListView vl = (ListView)sender;
            part =(Pays) vl.SelectedItem;
            await Navigation.PushModalAsync(new MyPage_Ville());
        }
    }
}
