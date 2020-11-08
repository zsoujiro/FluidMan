using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace FluidMan
{
    public class Units
    {
        public static void Write_UnitTable(Stream fileStream)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlNode;
            XmlNode xmlNodeChild;
            XmlAttribute xmlAttribute;

            xmlNode = xmlDocument.CreateNode(XmlNodeType.Element, "list_unit_system", "");
            xmlDocument.AppendChild(xmlNode);

            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit_system", "");
            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "SI";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);

            xmlNode = xmlNodeChild;

            #region length
            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit", "");
            
            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "meter";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("symbol");
            xmlAttribute.Value = "m";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("type");
            xmlAttribute.Value = "length";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("c1");
            xmlAttribute.Value = "1";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);
            #endregion

            #region time
            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit", "");

            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "second";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("symbol");
            xmlAttribute.Value = "s";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("type");
            xmlAttribute.Value = "time";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("c1");
            xmlAttribute.Value = "1";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);
            #endregion

            #region mass
            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit", "");

            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "kilogram";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("symbol");
            xmlAttribute.Value = "kg";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("type");
            xmlAttribute.Value = "mass";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("c1");
            xmlAttribute.Value = "1";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);
            #endregion

            #region temperature
            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit", "");

            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "kelvin";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("symbol");
            xmlAttribute.Value = "K";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("type");
            xmlAttribute.Value = "temperature";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("c1");
            xmlAttribute.Value = "1";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);
            #endregion

            #region electric_current
            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit", "");

            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "ampere";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("symbol");
            xmlAttribute.Value = "A";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("type");
            xmlAttribute.Value = "electric_current";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("c1");
            xmlAttribute.Value = "1";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);
            #endregion

            #region quantity
            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit", "");

            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "mole";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("symbol");
            xmlAttribute.Value = "mol";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("type");
            xmlAttribute.Value = "quantity";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("c1");
            xmlAttribute.Value = "1";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);
            #endregion

            #region brightness
            xmlNodeChild = xmlDocument.CreateNode(XmlNodeType.Element, "unit", "");

            xmlAttribute = xmlDocument.CreateAttribute("name");
            xmlAttribute.Value = "candela";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("symbol");
            xmlAttribute.Value = "cd";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("type");
            xmlAttribute.Value = "length";
            xmlNodeChild.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlDocument.CreateAttribute("c1");
            xmlAttribute.Value = "1";
            xmlNodeChild.Attributes.Append(xmlAttribute);
            xmlNode.AppendChild(xmlNodeChild);
            #endregion

            xmlDocument.Save(fileStream);
            
        }
        public void Read_UnitTable(XmlDocument xmlDocument)
        {

        }
    }
}
