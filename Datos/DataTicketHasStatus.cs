﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos
{
    public class DataTicketHasStatus
    {
        public RelTicketHasStatus[] getAll()
        {
            List<RelTicketHasStatus> relations = new List<RelTicketHasStatus>();
            using (var db = new ToDoListContext())
            {
                var query = from u in db.REL_TICKET_HAS_STATUS
                            orderby u.id ascending
                            select u;
                foreach(var item in query)
                {
                    RelTicketHasStatus relation = new RelTicketHasStatus();
                    relation.Id = item.id;
                    relation.Date = item.date;
                    relation.IdTicket = item.id_ticket;
                    relation.idStatus = item.id_status;
                    relations.Add(relation);
                }
            }
            return relations.ToArray();

        }
    }
}