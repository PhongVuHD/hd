using HD.Station.Data.MediaAssets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.Data
{
    public partial class AppDbContext
    {
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetHash> AssetHash { get; set; }
        public virtual DbSet<AssetLocator> AssetLocator { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<Channel> Channel { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<ContentGenre> ContentGenre { get; set; }
        public virtual DbSet<ContentSubject> ContentSubject { get; set; }
        public virtual DbSet<ContentTargetAudience> ContentTargetAudience { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<MineType> MineType { get; set; }
        public virtual DbSet<Programme> Programme { get; set; }
        public virtual DbSet<ProgrammeChannel> ProgrammeChannel { get; set; }
        public virtual DbSet<StorageLocation> StorageLocation { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<TargetAudience> TargetAudience { get; set; }
    }
}