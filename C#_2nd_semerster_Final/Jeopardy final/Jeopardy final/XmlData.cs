using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy_final
{
    
   public  class XmlData
    {


        // list created to hold xml data
        List<String> xmllist = new List<String>();
        public List<String> Get_XMLData()
        {
            // Start with XmlReader object  
            //here, we try to setup Stream between the XML file nad xmlReader  
            using (XmlReader reader = XmlReader.Create(@"Jeopardy.xml"))
            {
                while (reader.Read())
                {
                    // reader reads and pulls the all of the xml data into the string including attributes to be used for Cats, answers,questions, and points
                    if (reader.IsStartElement())
                    {

                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {

                            case "first":
                                xmllist.Add(reader.GetAttribute("points"));
                                xmllist.Add(reader.GetAttribute("answer"));
                                xmllist.Add(reader.ReadString());
                                break;

                            case "second":
                                xmllist.Add(reader.GetAttribute("points"));
                                xmllist.Add(reader.GetAttribute("answer"));
                                xmllist.Add(reader.ReadString());
                                break;
                            case "third":
                                xmllist.Add(reader.GetAttribute("points"));
                                xmllist.Add(reader.GetAttribute("answer"));
                                xmllist.Add(reader.ReadString());
                                break;
                            case "fourth":
                                xmllist.Add(reader.GetAttribute("points"));
                                xmllist.Add(reader.GetAttribute("answer"));
                                xmllist.Add(reader.ReadString());
                                break;
                            case "fifth":
                                xmllist.Add(reader.GetAttribute("points"));
                                xmllist.Add(reader.GetAttribute("answer"));
                                xmllist.Add(reader.ReadString());
                                break;

                        }
                        //if the attribute pulled is a null the attribute will not be added but if it isn't aka the catagory names, they get added to the list.
                        if (reader.GetAttribute("name") == null)
                        {
                        }
                        else
                        {
                            xmllist.Add(reader.GetAttribute("name"));
                        }
                        
                    }

                }
            }

            return xmllist;

        }




    }
}
