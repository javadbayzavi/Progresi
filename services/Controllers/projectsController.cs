using services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace services.Controllers
{
    public class projectsController : ApiController
    {
        //get the list of all projects of user
        public IEnumerable<progresi_bunches> getProjects(string uid,string session)
        {
            return null;
        }
        //get specific instance of a project
        public progresi_bunches getProject(int id,string uid,string session)
        {
         // TODO: Develop some code here
          return null;
        }

        public bool setProject(progresi_bunches project)
        {
            //TODO: develop some code to create new project
            return true;
        }

        public bool updateProject(progresi_bunches project)
        {
            //TODO: develop some code to update an entry project
            return true;
        }

        public bool deleteProject(int id)
        {
            //TODO: develop some code to delete entry project
            return true;
        }

        public IEnumerable<progresi_stages> getStages(int pid)
        {
            //TODO: develop some code to get project stages
            return null;
        }
        public IEnumerable<progresi_teams> getTeams(int tid)
        {
            //TODO: develop some code to get project teams
            return null;
        }
    }
}