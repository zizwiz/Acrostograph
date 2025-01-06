using System;
using System.Windows.Forms;
using System.Xml;

namespace Acrostograph.utilities
{
    class XMLUtils
    {

        void PopulateColourFiltersCmboBx(ComboBox myComboBox, string FilterToSelect)
        {
            // A different thread watch cross threading
            //populate the combo boxes with the airfield names direct from xml file so we get 
            //names correctly spelt for later look up

            string filter = "Reset";

            //Make sure Combobox is clear
            myComboBox.Items.Clear();

            //Get the xmlfile
            XmlDocument doc = new XmlDocument();
            doc.Load("ColourFilterData.xml");
            XmlNodeList ColourFilterList = doc.SelectNodes("ColourFilter/Data/name");

            foreach (XmlNode Name in ColourFilterList)
            {
                // data is content of each name
                string[] data = ColourFilterData.GetColourFilterData(Name.InnerText);

                myComboBox.Items.Add(Name.InnerText);


                filter = Name.InnerText;
            }
            
            //Set to "Reset" filter
            if (FilterToSelect == "Reset") filter = "Reset";
            myComboBox.SelectedItem = filter;
        }











    }
}
