/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("sequenceFlow", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class SequenceFlow : FlowElement {
    
    private Expression conditionExpressionField;
    
    private string sourceRefField;
    
    private string targetRefField;
    
    private bool isImmediateField;
    
    private bool isImmediateFieldSpecified;
    
    /// <remarks/>
    public Expression conditionExpression {
        get {
            return this.conditionExpressionField;
        }
        set {
            this.conditionExpressionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
    public string sourceRef {
        get {
            return this.sourceRefField;
        }
        set {
            this.sourceRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
    public string targetRef {
        get {
            return this.targetRefField;
        }
        set {
            this.targetRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isImmediate {
        get {
            return this.isImmediateField;
        }
        set {
            this.isImmediateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isImmediateSpecified {
        get {
            return this.isImmediateFieldSpecified;
        }
        set {
            this.isImmediateFieldSpecified = value;
        }
    }
}