#nullable disable
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("outputSet", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class OutputSet : BaseElement {
    
    private string[] dataOutputRefsField;
    
    private string[] optionalOutputRefsField;
    
    private string[] whileExecutingOutputRefsField;
    
    private string[] inputSetRefsField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataOutputRefs", DataType="IDREF")]
    public string[] dataOutputRefs {
        get {
            return this.dataOutputRefsField;
        }
        set {
            this.dataOutputRefsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("optionalOutputRefs", DataType="IDREF")]
    public string[] optionalOutputRefs {
        get {
            return this.optionalOutputRefsField;
        }
        set {
            this.optionalOutputRefsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("whileExecutingOutputRefs", DataType="IDREF")]
    public string[] whileExecutingOutputRefs {
        get {
            return this.whileExecutingOutputRefsField;
        }
        set {
            this.whileExecutingOutputRefsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("inputSetRefs", DataType="IDREF")]
    public string[] inputSetRefs {
        get {
            return this.inputSetRefsField;
        }
        set {
            this.inputSetRefsField = value;
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