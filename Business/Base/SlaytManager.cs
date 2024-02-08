using Business.Abstract;
using DataAccess.Absract.Repository;
using Shared.Dtos;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Base
{
    public class SlaytManager : ISlaytServices
    {
        private readonly IRepository<Slaytlar> _slaytRepository;

        public SlaytManager(IRepository<Slaytlar> slaytRepository)
        {
            _slaytRepository = slaytRepository;
        }

        public SlaytlarDto GetSlaytById(int id)
        {
            var responseCvap = _slaytRepository.GetByID(id);

            SlaytlarDto result = SlaytItem(responseCvap);
            return result;

        }

        public List<SlaytlarDto> GetSlaytlar()
        {
            var response = _slaytRepository.GetAll().ToList();

            List<SlaytlarDto> result = new List<SlaytlarDto>();

            foreach (var item in response)
            {
                result.Add(SlaytItem(item));
            }

            return result;
        }

        public SlaytlarDto InsertSlayt(SlaytlarDto model)
        {
            Slaytlar response = _slaytRepository.Insert(SlaytItem(model));
            SlaytlarDto result = SlaytItem(response);

            return result;
        }


        public SlaytlarDto UpdateSlayt(SlaytlarDto model)
        {
            Slaytlar response = _slaytRepository.Update(SlaytItem(model));
            SlaytlarDto result = SlaytItem(response);

            return result;
        }

        public bool DeleteSlaytlar(int id)
        {
            return _slaytRepository.Delete(new Slaytlar());
        }

        private SlaytlarDto SlaytItem(Slaytlar model)
        {
            SlaytlarDto result = new SlaytlarDto();

            result.Id = model.Id;
            result.Icerik = model.Icerik;
            result.HaberID = model.HaberID;
            result.Resim = model.Resim;
            result.AktifMi = model.AktifMi;
            result.Basligi = model.Basligi;

            return result;
          
        }

        private Slaytlar SlaytItem(SlaytlarDto model)
        {
            Slaytlar result = new Slaytlar();

            result.Id = model.Id;
            result.Icerik = model.Icerik;
            result.HaberID = model.HaberID;
            result.Resim = model.Resim;
            result.AktifMi = model.AktifMi;
            result.Basligi = model.Basligi;

            return result;
        }

    }
}
