using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {

            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,

            };
        }
        public static Stock ToStockFromCreateDto(this CreateStockRequestDto StockDto)
        {
            return new Stock
            {
Symbol=StockDto.Symbol,
            };
        }
    }
}