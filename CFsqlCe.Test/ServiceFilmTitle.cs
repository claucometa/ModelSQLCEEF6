using CFSqlCe.Dal;
using CFSqlCe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFSqlCe.Test
{
    public class ServiceFilmTitle
    {
        CrudRepo<Model.FilmTitle> repo = new CrudRepo<Model.FilmTitle>();
        
        public void Add(FilmGenere actionGenere)
        {
            var f = new Model.FilmTitle()
           {
               Title = "Mission: Impossible III",
               ReleaseYear = 2006,
               Duration = 126,
               Story = "Ethan Hunt comes face to face with a dangerous and ...",
               FilmGenere = actionGenere
           };
           repo.Add(f);           
        }

        public void Save()
        {
            repo.Save();            
        }
    }
}
