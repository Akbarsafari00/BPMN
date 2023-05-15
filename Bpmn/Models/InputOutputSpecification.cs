#nullable disable
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("ioSpecification", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class InputOutputSpecification : BaseElement {
    
    private DataInput[] dataInputField;
    
    private DataOutput[] dataOutputField;
    
    private InputSet[] inputSetField;
    
    private OutputSet[] outputSetField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataInput")]
    public DataInput[] dataInput {
        get {
            return this.dataInputField;
        }
        set {
            this.dataInputField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataOutput")]
    public DataOutput[] dataOutput {
        get {
            return this.dataOutputField;
        }
        set {
            this.dataOutputField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("inputSet")]
    public InputSet[] inputSet {
        get {
            return this.inputSetField;
        }
        set {
            this.inputSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("outputSet")]
    public OutputSet[] outputSet {
        get {
            return this.outputSetField;
        }
        set {
            this.outputSetField = value;
        }
    }
}