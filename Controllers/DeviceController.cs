using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Entities;

namespace MyFirstAPI.Controllers;
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var smartPhone = new SmartPhone();
        var laptop = new Laptop();
        var modal = laptop.GetModal();
        var brand = laptop.GetBrand();
        var customKey = GetCustomKey();

        var device = $"Brand: {brand} - Modal: {modal} - SmartPhone: {smartPhone.GetBrand()} - CustomKey: {customKey}";

        return Ok(device);
    }

    [HttpGet("colors")]
    public IActionResult GetColors()
    {
        var smartPhone = new SmartPhone();
        var laptop = new Laptop();
        var smartPhoneColor = smartPhone.GetColor();
        var laptopColor = laptop.GetColor();

        var colors = $"SmartPhone: {smartPhoneColor} - Laptop: {laptopColor}";

        return Ok(colors);
    }
}
