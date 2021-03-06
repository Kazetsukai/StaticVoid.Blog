﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticVoid.Repository;
using System.Data.Entity;

namespace StaticVoid.Blog.Data
{
	public static class RedirectRepositoryExtensions
	{
        public static IEnumerable<Redirect> GetRedirects(this IRepository<Redirect> repo)
		{
			return repo.GetAll().AsNoTracking().AsEnumerable();
		}

        public static Redirect GetRedirectFor(this IRepository<Redirect> repo, string url)
        {
            return repo.GetBy(r => r.OldRoute == url);
        }
	}
}
