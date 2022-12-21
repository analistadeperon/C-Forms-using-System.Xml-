using Microsoft.Office.InfoPath;
 using System;
 using System.Windows.Forms;
 using System.Xml;
 using System.Xml.XPath;
 namespace HelloWorld
 {
     public partial class FormCode
     {
         public void InternalStartup()
         {
         ((ButtonEvent)EventManager.ControlEvents["CTRL1_5"]).Clicked += new ClickedEventHandler(CTRL1_5_Clicked);
         }
         public void CTRL1_5_Clicked(object sender, ClickedEventArgs e)
         {
         MessageBox.Show("Hello World!");
         }
     }
 }
