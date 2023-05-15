/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("multiInstanceLoopCharacteristics", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class MultiInstanceLoopCharacteristics : LoopCharacteristics {
    
    private Expression loopCardinalityField;
    
    private System.Xml.XmlQualifiedName loopDataInputRefField;
    
    private System.Xml.XmlQualifiedName loopDataOutputRefField;
    
    private DataInput inputDataItemField;
    
    private DataOutput outputDataItemField;
    
    private ComplexBehaviorDefinition[] complexBehaviorDefinitionField;
    
    private Expression completionConditionField;
    
    private bool isSequentialField;
    
    private MultiInstanceFlowCondition behaviorField;
    
    private System.Xml.XmlQualifiedName oneBehaviorEventRefField;
    
    private System.Xml.XmlQualifiedName noneBehaviorEventRefField;
    
    public MultiInstanceLoopCharacteristics() {
        this.isSequentialField = false;
        this.behaviorField = MultiInstanceFlowCondition.All;
    }
    
    /// <remarks/>
    public Expression loopCardinality {
        get {
            return this.loopCardinalityField;
        }
        set {
            this.loopCardinalityField = value;
        }
    }
    
    /// <remarks/>
    public System.Xml.XmlQualifiedName loopDataInputRef {
        get {
            return this.loopDataInputRefField;
        }
        set {
            this.loopDataInputRefField = value;
        }
    }
    
    /// <remarks/>
    public System.Xml.XmlQualifiedName loopDataOutputRef {
        get {
            return this.loopDataOutputRefField;
        }
        set {
            this.loopDataOutputRefField = value;
        }
    }
    
    /// <remarks/>
    public DataInput inputDataItem {
        get {
            return this.inputDataItemField;
        }
        set {
            this.inputDataItemField = value;
        }
    }
    
    /// <remarks/>
    public DataOutput outputDataItem {
        get {
            return this.outputDataItemField;
        }
        set {
            this.outputDataItemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("complexBehaviorDefinition")]
    public ComplexBehaviorDefinition[] complexBehaviorDefinition {
        get {
            return this.complexBehaviorDefinitionField;
        }
        set {
            this.complexBehaviorDefinitionField = value;
        }
    }
    
    /// <remarks/>
    public Expression completionCondition {
        get {
            return this.completionConditionField;
        }
        set {
            this.completionConditionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isSequential {
        get {
            return this.isSequentialField;
        }
        set {
            this.isSequentialField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(MultiInstanceFlowCondition.All)]
    public MultiInstanceFlowCondition behavior {
        get {
            return this.behaviorField;
        }
        set {
            this.behaviorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName oneBehaviorEventRef {
        get {
            return this.oneBehaviorEventRefField;
        }
        set {
            this.oneBehaviorEventRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName noneBehaviorEventRef {
        get {
            return this.noneBehaviorEventRefField;
        }
        set {
            this.noneBehaviorEventRefField = value;
        }
    }
}