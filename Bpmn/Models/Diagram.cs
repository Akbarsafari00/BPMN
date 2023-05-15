#nullable disable
/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(BPMNDiagram))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DI")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DI", IsNullable=false)]
public abstract partial class Diagram {
    
    private string nameField;
    
    private string documentationField;
    
    private double resolutionField;
    
    private bool resolutionFieldSpecified;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string documentation {
        get {
            return this.documentationField;
        }
        set {
            this.documentationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public double resolution {
        get {
            return this.resolutionField;
        }
        set {
            this.resolutionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool resolutionSpecified {
        get {
            return this.resolutionFieldSpecified;
        }
        set {
            this.resolutionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}