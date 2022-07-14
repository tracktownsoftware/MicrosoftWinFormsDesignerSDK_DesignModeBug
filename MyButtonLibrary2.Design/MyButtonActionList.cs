using Microsoft.DotNet.DesignTools.Designers.Actions;
using Microsoft.DotNet.DesignTools.Designers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonLibrary2.Design
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
                "DesignModeValueBug",
                "Dialog scenario showing DesignMode incorrectly false at design-time...",
                "",
                "",
                true));
            return items;
        }


        public MyButton MyButton
        {
            get { return (MyButtonLibrary2.MyButton)Component!; }
        }

        public void DesignModeValueBug()
        {
            using (MyButtonDialog dlg = new MyButtonDialog())
            {
                var dialogResult = dlg.ShowDialog(MyButton);
            }
        }
    }
}
