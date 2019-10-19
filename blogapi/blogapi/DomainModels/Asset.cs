using System;

namespace blogapi.DomainModels
{
    public class Asset : BaseEntity
    {

        public AssetType AssetType { get; set; }

        public string AssetTypeId { get; set; }

        public string AssetPath { get; set; }

        //set asset expiry if article isn't that great.
    }
}