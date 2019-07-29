﻿using GhostBusters_Forms.Mapper;
using GhostBusters_Forms.Model;
using GhostBusters_Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostBusters_Forms.Controller
{
    public class LogController
    {
        public LogModel Cadastro(LogModel log)
        {
            return new LogRepository().CadastroLog(log.MapLogEntity()).MapLogModel();
        }
        public List<LogModel> FindByCodigoChamado(int id)
        {
            return new LogRepository().FindByLog(id).Select(Log => Log.MapLogModel()).ToList();
        }
    }
}
