﻿namespace DNCommerce.Framework.BuildingBlocks.Catalog.DTO
{
    public class InsertProductDto
    {
        public string Name { get; set; }

        public string Feature { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int QuantityInStock { get; internal set; }

        public int Weight { get; internal set; }
    }
}