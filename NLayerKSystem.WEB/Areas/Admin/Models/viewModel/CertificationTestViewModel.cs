﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestEF.MyDbContext;

namespace NLayerKSystem.WEB.Areas.Admin.Models.viewModel
{
    public class CertificationTestViewModel
    {
        public int Id { get; set; }
        public string Resource { get; set; }
        public string Evaluation { get; set; }
        public string CertificationPhoto { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public int? KnowledgeId { get; set; }
        public Knowledge Knowledge { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

        public string CountryName
        {
            get
            {
                return City?.Country.Name ?? "";
            }
        }

        public string CityName
        {
            get
            {
                return City?.Name ?? "";
            }
        }

        public IEnumerable<CityViewModel> CityViewModels { get; set; }

        public string KnowledgeName
        {
            get
            {
                return Knowledge?.Name ?? "";
            }
        }

        public IEnumerable<KnowledgeViewModel> KnowledgeViewModels { get; set; }

        public string UserRole
        {
            get
            {
                return User?.Role.Name ?? "";
            }
        }

        public string UserName
        {
            get
            {
                return User?.Name ?? "";
            }
        }

        public IEnumerable<UserViewModel> UserViewModels { get; set; }
    }
}