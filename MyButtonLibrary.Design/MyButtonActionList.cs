using Microsoft.DotNet.DesignTools.Designers.Actions;
using Microsoft.DotNet.DesignTools.Designers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonLibrary.Design
{
    internal class MyButtonActionList : DesignerActionList
    {
        private readonly ComponentDesigner _designer;

        public MyButtonActionList(MyButtonDesigner designer) : base(designer.Component)
        {
            _designer = designer;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionMethodItem(
                this,
                "ApplicationSettingsBug",
                "Change button text using application setting - This FAILS",
                "",
                "",
                true));
            items.Add(new DesignerActionMethodItem(
                this,
                "HardCodedStringTest",
                "Change button text using hard coded text - SUCCESS",
                "",
                "",
                true));
            return items;
        }


        public MyButton MyButton
        {
            get { return (MyButtonLibrary.MyButton)Component!; }
        }

        public void HardCodedStringTest()
        {
            MyButton.HardCodedStringTest();
        }

        public void ApplicationSettingsBug()
        {
            MyButton.ApplicationSettingsTest();
        }
    }
}
