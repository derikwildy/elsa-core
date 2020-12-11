using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Elsa.Models;
using Elsa.Persistence;

namespace Elsa.Services
{
    public interface IWorkflowDefinitionManager
    {
        IWorkflowDefinitionStore Store { get; }
        Task SaveAsync(WorkflowDefinition workflowDefinition, CancellationToken cancellationToken = default);
        Task DeleteAsync(WorkflowDefinition workflowDefinition, CancellationToken cancellationToken = default);
        Task<int> CountAsync(VersionOptions? version = default, CancellationToken cancellationToken = default);
        Task<IEnumerable<WorkflowDefinition>> ListAsync(int? skip = default, int? take = default, VersionOptions? version = default, CancellationToken cancellationToken = default);
        Task<WorkflowDefinition?> GetAsync(string workflowDefinitionId, VersionOptions version, CancellationToken cancellationToken = default);
        Task<WorkflowDefinition?> GetByVersionIdAsync(string workflowDefinitionVersionId, CancellationToken cancellationToken = default);
    }
}
