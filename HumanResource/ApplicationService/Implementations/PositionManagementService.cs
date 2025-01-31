using ApplicationService.DTOs;
using Data.Context;
using Data.Entities;
using System;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Implementations;

namespace ApplicationService.Implementations
{
    public class PositionManagementService
    {

        private HRDbContext ctx = new HRDbContext();

        public List<PositionDTO> Get(string searchPos)
        {
            List<PositionDTO> positionDTOs = new List<PositionDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.PositionRepository.Get(p => p.TypePosition.Contains(searchPos)))
                {
                    positionDTOs.Add(new PositionDTO
                    {
                        Id = item.Id,
                        TypePosition = item.TypePosition,
                        Name = item.Name,
                        Department = item.Departament
                    });

                }
            }

            return positionDTOs;
        }

      

        public PositionDTO GetById(int id)
        {
            PositionDTO positionDTO = new PositionDTO();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
               
                Position position = unitOfWork.PositionRepository.GetByID(id);
                if (position != null)
                {
                    positionDTO.Id = positionDTO.Id;
                    positionDTO.TypePosition = positionDTO.TypePosition;
                    positionDTO.Name = positionDTO.Name;
                    positionDTO.Department = positionDTO.Department;

                }
            }
            return positionDTO;
        }

        public bool Update(PositionDTO positionDTO)
        {
            Position position = new Position
            {
                Id = positionDTO.Id,
                TypePosition = positionDTO.TypePosition,
                Name = positionDTO.Name,
                Departament = positionDTO.Department

            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.PositionRepository.Update(position);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save(PositionDTO positionDto)
        {
            Position position = new Position
            {
                TypePosition = positionDto.TypePosition,
                Name = positionDto.Name,
                Departament = positionDto.Department

            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.PositionRepository.Insert(position);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Position position = unitOfWork.PositionRepository.GetByID(id);
                    unitOfWork.PositionRepository.Delete(position);
                    unitOfWork.Save();
                }

                return true;

            }
            catch
            {
                return false;

            }
        }
    }
}
