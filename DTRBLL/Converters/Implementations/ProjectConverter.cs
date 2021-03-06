﻿using System;
using System.Collections.Generic;
using System.Text;
using DTRBLL.BusinessObjects;
using DTRDAL.Entities;

namespace DTRBLL.Converters.Implementations
{
    internal class ProjectConverter : IConverter<Project, ProjectBO>
    {

        public Project Convert(ProjectBO bo)
        {
            if (bo == null) return null;
            return new Project
            {
                Id = bo.Id,
                AssignedSupervisorId = bo.AssignedSupervisorId,
                Description = bo.Description,
                Title = bo.Title,
                Start = bo.Start,
                WantedSupervisorId = bo.WantedSupervisorId,
                End = bo.End
            };
        }

        public ProjectBO Convert(Project entity)
        {
            if (entity == null) return null;
            return new ProjectBO
            {
                Id = entity.Id,
                AssignedSupervisorId = entity.AssignedSupervisorId,
                Description = entity.Description,
                Title = entity.Title,
                Start = entity.Start,
                WantedSupervisorId = entity.WantedSupervisorId,
                End = entity.End
            };
        }
    }
}
