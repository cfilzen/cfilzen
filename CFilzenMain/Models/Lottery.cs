using System.ComponentModel.DataAnnotations;

namespace CFilzenMain.Models
{
    public class FLLottoModel : LottoModel
    {
        [Required]
        [DataType(DataType.Text)]
        public int Pick1 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick3 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick4 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick5 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick6 { get; set; }
    }

    public class FLPowerBallModel : LottoModel
    {
        [Required]
        [DataType(DataType.Text)]
        public int Pick1 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick3 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick4 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick5 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int PickPB { get; set; }

    }

    public class FLMegaMillModel : LottoModel
    {
        [Required]
        [DataType(DataType.Text)]
        public int Pick1 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick3 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick4 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick5 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int PickMegaBall { get; set; }
    }

    public class FLCash4LifeModel : LottoModel
    {
        [Required]
        [DataType(DataType.Text)]
        public int Pick1 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick3 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick4 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick5 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int PickCashBall { get; set; }

    }
    public class FLJackpotTriplePlayLottoModel : LottoModel
    {
        [Required]
        [DataType(DataType.Text)]
        public int Pick1 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick3 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick4 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick5 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int Pick6 { get; set; }
    }

    public class FLCashPopLottoModel : LottoModel
    {
        [Required]
        [DataType(DataType.Text)]
        public int Pick1 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick2 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick3 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick4 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick5 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick6 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick7 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick8 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick9 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick10 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick11 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick12 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick13 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick14 { get; set; }

        [DataType(DataType.Text)]
        public int? Pick15 { get; set; }

    }

    public abstract class LottoModel
    {
        [DataType(DataType.Text)]
        public string? Message { get; set; }
    }
}