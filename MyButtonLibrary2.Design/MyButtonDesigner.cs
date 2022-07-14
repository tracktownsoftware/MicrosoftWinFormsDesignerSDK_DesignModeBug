using Microsoft.DotNet.DesignTools.Designers;
using Microsoft.DotNet.DesignTools.Designers.Actions;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyButtonLibrary2.Design
{
    internal class MyButtonDesigner : ControlDesigner
    {
        private MyButtonLibrary2.MyButton? _myButton;
        private DesignerActionListCollection? _actionLists;
        private IComponentChangeService? _componentChangeService;
        private DesignerActionUIService? _designerActionUIService;

        [System.Reflection.Obfuscation(Feature = "trigger", Exclude = false)]
        internal static void DontRemoveConstructor()
        {
            new MyButtonDesigner();
        }

        public MyButtonDesigner()
        {
        }

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            _myButton = component as MyButtonLibrary2.MyButton;
            if (_myButton != null)
            {
                _myButton.Width = 200;
                _myButton.Height = 150;
            }
        }

        private void InitializeServices()
        {
            if (_componentChangeService == null)
            {
                _designerActionUIService =
                    GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
                _componentChangeService =
                    GetService(typeof(IComponentChangeService)) as IComponentChangeService;
            }
        }

        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (_actionLists == null)
                    _actionLists = new DesignerActionListCollection();

                // Visual Studio seems to call this before Initialize where the WorkbookView
                // reference is set up.
                if (_myButton != null)
                {
                    // We InitializeServices here so that the control is up and visible
                    // before we hook the ComponentChangeService to the control since
                    // the control can fire changed events that cause the form to 
                    // already need saved before the user actually changes anything.
                    InitializeServices();

                    if (_actionLists.Count == 0)
                        _actionLists.Add(new MyButtonActionList(this));
                }
                return _actionLists;
            }
        }
    }


}
