using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.classes.updates
    
{
    public class check
    {
        GitHubProject GitHubProject = new GitHubProject();
        
        public async Task<bool> IsUpdates()
        {
            var project = await GitHubProject.getProject();
            
            
            return true;
        }
    }
}
