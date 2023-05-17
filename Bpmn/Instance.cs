using Bpmn.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bpmn
{
    public class Instance
    {
        private readonly Definitions _definitions;

        public Instance(string diagram)
        {
            var inputString = File.ReadAllText("C:\\Users\\isar\\source\\repos\\BPMN\\Bpmn.Console\\" + diagram);
            var serializer = new XmlSerializer(typeof(Definitions));
            var memStream = new MemoryStream(Encoding.UTF8.GetBytes(inputString));

            _definitions = (Definitions)serializer.Deserialize(memStream)!;
        }

        public IEnumerable<Process> AllProcess()
        {
            return _definitions.Items.FindElementsByType<Process>();
        }

       
    }
}
