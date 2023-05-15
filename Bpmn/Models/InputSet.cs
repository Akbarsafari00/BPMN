#nullable disable
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("inputSet", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class InputSet : BaseElement {
    
    private string[] dataInputRefsField;
    
    private string[] optionalInputRefsField;
    
    private string[] whileExecutingInputRefsField;
    
    private string[] outputSetRefsField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataInputRefs", DataType="IDREF")]
    public string[] dataInputRefs {
        get {
            return this.dataInputRefsField;
        }
        set {
            this.dataInputRefsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("optionalInputRefs", DataType="IDREF")]
    public string[] optionalInputRefs {
        get {
            return this.optionalInputRefsField;
        }
        set {
            this.optionalInputRefsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("whileExecutingInputRefs", DataType="IDREF")]
    public string[] whileExecutingInputRefs {
        get {
            return this.whileExecutingInputRefsField;
        }
        set {
            this.whileExecutingInputRefsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("outputSetRefs", DataType="IDREF")]
    public string[] outputSetRefs {
        get {
            return this.outputSetRefsField;
        }
        set {
            this.outputSetRefsField = value;
        }
    }
    
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
}