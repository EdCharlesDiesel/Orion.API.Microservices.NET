using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.DataAccess.Postgres.Entities.ECommerce
{
    [Table("Production.Document")]
    [Description("Product maintenance documents.")]
    public class Document
    {
        public Document()
        {
            this.ProductDocuments = new List<ProductDocument>();
        }

        [Key]
        [Column(Name = "DocumentNode", TypeName = "hierarchyid")]
        [Required(ErrorMessage = "Document Node is required")]
        [Display(Name = "Document Node")]
        [Description("Primary key for Document records.")]
        public SqlHierarchyId DocumentNode { get; set; } // hierarchyid
        [Column(Name = "DocumentLevel", TypeName = "smallint")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Document Level")]
        [Description("Depth in the document hierarchy.")]
        public short? DocumentLevel { get; set; } // smallint
        [Column(Name = "Title", TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        [Description("Title of the document.")]
        public string Title { get; set; } // nvarchar(50)
        [Column(Name = "Owner", TypeName = "int")]
        [Required(ErrorMessage = "Owner is required")]
        [Display(Name = "Owner")]
        [Description("Employee who controls the document.  Foreign key to Employee.BusinessEntityID")]
        public int? Owner { get; set; } // int
        [Column(Name = "FolderFlag", TypeName = "bit")]
        [Required(ErrorMessage = "Folder Flag is required")]
        [Display(Name = "Folder Flag")]
        [Description("0 = This is a folder, 1 = This is a document.")]
        public bool? FolderFlag { get; set; } // bit
        [Column(Name = "FileName", TypeName = "nvarchar")]
        [MaxLength(400)]
        [StringLength(400)]
        [Required(ErrorMessage = "File Name is required")]
        [Display(Name = "File Name")]
        [Description("File name of the document")]
        public string FileName { get; set; } // nvarchar(400)
        [Column(Name = "FileExtension", TypeName = "nvarchar")]
        [MaxLength(8)]
        [StringLength(8)]
        [Required(ErrorMessage = "File Extension is required")]
        [Display(Name = "File Extension")]
        [Description("File extension indicating the document type. For example, .doc or .txt.")]
        public string FileExtension { get; set; } // nvarchar(8)
        [Column(Name = "Revision", TypeName = "nchar")]
        [MaxLength(5)]
        [StringLength(5)]
        [Required(ErrorMessage = "Revision is required")]
        [Display(Name = "Revision")]
        [Description("Revision number of the document. ")]
        public string Revision { get; set; } // nchar(5)
        [Column(Name = "ChangeNumber", TypeName = "int")]
        [Required(ErrorMessage = "Change Number is required")]
        [Display(Name = "Change Number")]
        [Description("Engineering change approval number.")]
        public int? ChangeNumber { get; set; } // int
        [Column(Name = "Status", TypeName = "tinyint")]
        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        [Description("1 = Pending approval, 2 = Approved, 3 = Obsolete")]
        public byte? Status { get; set; } // tinyint
        [Column(Name = "DocumentSummary", TypeName = "nvarchar")]
        [MaxLength]
        [Display(Name = "Document Summary")]
        [Description("Document abstract.")]
        public string DocumentSummary { get; set; } // nvarchar(max)
        [Column(Name = "Document", TypeName = "varbinary")]
        [MaxLength]
        [Display(Name = "Document")]
        [Description("Complete document.")]
        public byte[] Document { get; set; } // varbinary(max)
        [Column(Name = "rowguid", TypeName = "uniqueidentifier")]
        [Required(ErrorMessage = "rowguid is required")]
        [Display(Name = "rowguid")]
        [Description("ROWGUIDCOL number uniquely identifying the record. Required for FileStream.")]
        public Guid? rowguid { get; set; } // uniqueidentifier
        [Column(Name = "ModifiedDate", TypeName = "datetime")]
        [Required(ErrorMessage = "Modified Date is required")]
        [Display(Name = "Modified Date")]
        [Description("Date and time the record was last updated.")]
        public DateTime? ModifiedDate { get; set; } // datetime

        // Production.Document.Owner -> HumanResources.Employee.BusinessEntityID (FK_Document_Employee_Owner)
        public Employee Employee { get; set; }
        // Production.ProductDocument.DocumentNode -> Production.Document.DocumentNode (FK_ProductDocument_Document_DocumentNode)
        public IEnumerable<ProductDocument> ProductDocuments { get; set; }
    }
}
