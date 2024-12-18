namespace Mango.Services.CouponAPI.Models.Dto
{
    public class ResponseDTO
    {
        public Object? Result { get; set; }
        public bool IsSucces { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
