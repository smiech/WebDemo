﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDemoApi.DataAccessLayer;
using WebDemoApi.DataAccessLayer.Interface;
using WebDemoApi.Models;

namespace WebDemoApi.Repository
{
    public class MockableWordRepository:IMockableWordRepository,IDisposable
    {
        //JapaneseWordEntry = WebDemoApiContext?????
        private WebDemoEntities _context;
        

        public MockableWordRepository(WebDemoEntities context)
        {
            _context = context;
        }

        public void AddWord(JapaneseWord model)
        {

            using (var dbcontext = _context)
            {
                var entityModel = new JapaneseWordEntry(model);
                dbcontext.JapaneseWordEntries.Add(entityModel);
                dbcontext.SaveChanges();
            }
        }

        public List<JapaneseWord> GetAllWords()
        {
            using (var dbcontext = _context)
            {
                var results = dbcontext.JapaneseWordEntries.Select(x => new JapaneseWord (x.EntryId,x.Kanji,x.Hiragana,x.Romaji,x.AdditionalText,x.MotherTongueTranslation,x.MotherTongueTranslationLabel)).ToList();
                return results;
            }
        }

        public JapaneseWordEntry GetWord(int id)
        {
            using (var dbcontext = _context)
            {
                var result = dbcontext.JapaneseWordEntries.Where(x => x.EntryId == id).Select(x => x).FirstOrDefault();

                return result;
            }

        }

        public void DeleteWord(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("id");
            }

            using (var dbcontext = _context)
            {
                var result = dbcontext.JapaneseWordEntries.Where(x => x.EntryId == id).Select(x => x).FirstOrDefault();

                if (result == null)
                {
                    throw new ArgumentOutOfRangeException("id");
                }

                dbcontext.JapaneseWordEntries.Remove(result);
                dbcontext.SaveChanges();
            }




        }

        public void UpdateWord(JapaneseWordEntry model)
        {
            using (var dbcontext = _context)
            {
                var result = dbcontext.JapaneseWordEntries.Where(x => x.EntryId == model.EntryId).Select(x => x).Single();
                result = model;
                dbcontext.SaveChanges();
            }

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~MockableWordRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        JapaneseWordEntry IMockableWordRepository.GetWord(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}