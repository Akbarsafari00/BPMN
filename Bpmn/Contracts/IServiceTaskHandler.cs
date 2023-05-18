using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bpmn.Contracts
{
    public interface IServiceTaskHandler<TInput,TOutput> where TInput : IServiceTask<TOutput>
    {
        Task<TOutput> HandleAsync(TInput input);
    }
}
