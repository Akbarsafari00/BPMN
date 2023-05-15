/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataOutputAssociation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(DataInputAssociation))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("dataAssociation", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class DataAssociation : BaseElement {
    
    private string[] sourceRefField;
    
    private string targetRefField;
    
    private FormalExpression transformationField;
    
    private Assignment[] assignmentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sourceRef", DataType="IDREF")]
    public string[] sourceRef {
        get {
            return this.sourceRefField;
        }
        set {
            this.sourceRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="IDREF")]
    public string targetRef {
        get {
            return this.targetRefField;
        }
        set {
            this.targetRefField = value;
        }
    }
    
    /// <remarks/>
    public FormalExpression transformation {
        get {
            return this.transformationField;
        }
        set {
            this.transformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("assignment")]
    public Assignment[] assignment {
        get {
            return this.assignmentField;
        }
        set {
            this.assignmentField = value;
        }
    }
}