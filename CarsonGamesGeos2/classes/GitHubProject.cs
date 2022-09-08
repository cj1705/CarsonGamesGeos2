using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonGamesGeos2.classes
{
    public class GitHubProject
    {
        public async Task<GitHubClient> getProject()
        {
            var client = new GitHubClient(new ProductHeaderValue("CarsonGamesGeos2"));
            var user = await client.User.Get("cj1705");
            return client;

        }
    }
}
