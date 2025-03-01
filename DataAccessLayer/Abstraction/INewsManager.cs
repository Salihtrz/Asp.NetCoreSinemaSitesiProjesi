﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstraction
{
	public interface INewsManager<News>
	{
		List<News> GetAllNews();
		News GetNewsById(int id);
		void addNews(News news);
		void removeNews(News news);
		void updateNews(News news);
	}
}
