using CorporateTaskManagementSystem_V2.Model;
using System.Collections.Generic;

namespace CorporateTaskManagementSystem_V2.Controller
{
    public class TeamController
    {
        public void AddTeam(Team team)
        {
            Teams teams = new Teams();
            teams.AddTeam(team);
        }
        public void UpdateTeam(Team team)
        {
            Teams teams = new Teams();
            teams.UpdateTeam(team);
        }
        public void DeleteTeam(string teamId)
        {
            Teams teams = new Teams();
            teams.DeleteTeam(teamId);
        }

        public Team SearchTeam(string teamId)
        {
            Teams teams = new Teams();
            return teams.SearchTeam(teamId);
        }
        public List<Team> GetAllTeams()
        {
            Teams teams = new Teams();
            return teams.GetAllTeam();
        }
        public List<Team> GetAllTeamByDeptId(string deptId)
        {
            Teams teams = new Teams();
            return teams.GetAllTeamByDeptId(deptId);
        }
        public List<Team> GetTeamByDeptName(string deptName)
        {
            Teams teams = new Teams();
            return teams.GetTeamByDeptName(deptName);
            // Search team
        }
    }
}
