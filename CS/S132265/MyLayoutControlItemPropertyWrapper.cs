using DevExpress.XtraLayout;
using DevExpress.XtraEditors.Mask;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DXSample {
    public class MyLayoutControlItemPropertyWrapper : LayoutControlItemWrapper {
        protected TextEdit Editor { get { return Item.Control as TextEdit; } }

        [Category("Mask")]
        [DefaultValue(AutoCompleteType.Default)]
        public AutoCompleteType AutoComplete {
            get {
                if (Editor != null) return Editor.Properties.Mask.AutoComplete;
                else return AutoCompleteType.Default;
            }
            set { if (Editor != null) Editor.Properties.Mask.AutoComplete = value; }
        }

        [Category("Mask")]
        [DefaultValue(false)]
        public bool BeepOnError {
            get {
                if (Editor != null) return Editor.Properties.Mask.BeepOnError;
                else return false;
            }
            set { if (Editor != null) Editor.Properties.Mask.BeepOnError = value; }
        }

        [Category("Mask")]
        [DefaultValue("")]
        public string EditMask {
            get {
                if (Editor != null) return Editor.Properties.Mask.EditMask;
                else return string.Empty;
            }
            set { if (Editor != null) Editor.Properties.Mask.EditMask = value; }
        }

        [Category("Mask")]
        [DefaultValue(true)]
        public bool IgnoreMaskBlank {
            get {
                if (Editor != null) return Editor.Properties.Mask.IgnoreMaskBlank;
                else return true;
            }
            set { if (Editor != null) Editor.Properties.Mask.IgnoreMaskBlank = true; }
        }

        [Category("Mask")]
        [DefaultValue(MaskType.None)]
        public MaskType MaskType {
            get {
                if (Editor != null) return Editor.Properties.Mask.MaskType;
                else return MaskType.None;
            }
            set { if (Editor != null) Editor.Properties.Mask.MaskType = value; }
        }

        [Category("Mask")]
        [DefaultValue('\0')]
        public char PlaceHolder {
            get {
                if (Editor != null) return Editor.Properties.Mask.PlaceHolder;
                else return '\0';
            }
            set { if (Editor != null) Editor.Properties.Mask.PlaceHolder = '\0';  }
        }

        [Category("Mask")]
        [DefaultValue(true)]
        public bool SaveLiteral {
            get {
                if (Editor != null) return Editor.Properties.Mask.SaveLiteral;
                else return true;
            }
            set { if (Editor != null) Editor.Properties.Mask.SaveLiteral = value; }
        }

        [Category("Mask")]
        [DefaultValue(true)]
        public bool ShowPlaceHolders {
            get {
                if (Editor != null) return Editor.Properties.Mask.ShowPlaceHolders;
                else return true;
            }
            set { if (Editor != null) Editor.Properties.Mask.ShowPlaceHolders = value; }
        }

        [Category("Mask")]
        [DefaultValue(false)]
        public bool UseMaskAsDisplayFormat {
            get {
                if (Editor != null) return Editor.Properties.Mask.UseMaskAsDisplayFormat;
                else return false;
            }
            set { if (Editor != null) Editor.Properties.Mask.UseMaskAsDisplayFormat = value; }
        }
    }
}