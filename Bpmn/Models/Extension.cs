/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("extension", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Extension {
    
    private Documentation[] documentationField;
    
    private System.Xml.XmlQualifiedName definitionField;
    
    private bool mustUnderstandField;
    
    public Extension() {
        this.mustUnderstandField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("documentation")]
    public Documentation[] documentation {
        get {
            return this.documentationField;
        }
        set {
            this.documentationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName definition {
        get {
            return this.definitionField;
        }
        set {
            this.definitionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool mustUnderstand {
        get {
            return this.mustUnderstandField;
        }
        set {
            this.mustUnderstandField = value;
        }
    }
}