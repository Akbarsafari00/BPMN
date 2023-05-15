namespace Bpmn.Extensions;

public static class DefinitionsExtensions
{
    public static Process? FirstProcess(this Definitions definitions) =>
        definitions.Items.FirstElementsByType<Process>();
    
  
}