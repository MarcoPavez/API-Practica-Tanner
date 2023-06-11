using System;
using System.Collections.Generic;

namespace api_front.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Cell { get; set; }

    public string? Nat { get; set; }

    public string? Title { get; set; }

    public string? First { get; set; }

    public string? Last { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Postcode { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? TimezoneOffset { get; set; }

    public string? TimezoneDescription { get; set; }

    public string? Uuid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Salt { get; set; }

    public string? Md5 { get; set; }

    public string? Sha1 { get; set; }

    public string? Sha256 { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? Age { get; set; }

    public DateTime? RegisteredDate { get; set; }

    public int? RegisteredAge { get; set; }

    public string? PictureLarge { get; set; }

    public string? PictureMedium { get; set; }

    public string? PictureThumbnail { get; set; }

    public string? Seed { get; set; }

    public int? ResultsCount { get; set; }

    public int? Page { get; set; }

    public string? Version { get; set; }
}
