using GhostBusters_Forms.Mapper;
using GhostBusters_Forms.Model;
using GhostBusters_Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Controller
{
    public class StatusController
    {
        public List<StatusModel> FindAll()
        {
            
            return new StatusRepository().GetAll().Select(statusmodel => statusmodel.MapStatusModel()).ToList();
            //return new StatusRepository().FindALL().Select(statusmodel => statusmodel.MapStatusModel()).ToList();
        }
        public StatusModel FindByName(string nome)
        {
            return new StatusRepository().findbyName(nome).MapStatusModel();
        }



        internal StatusModel Cadastro(StatusModel statusModel)
        {
            return new StatusRepository().CadastroUpdate(statusModel.MapStatusEntity()).MapStatusModel();
        }
    }
 }

