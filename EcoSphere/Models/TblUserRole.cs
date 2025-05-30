﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoSphere.Models;

public partial class TblUserRole
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserRoleId { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TblRole? Role { get; set; }

    public virtual TblUser? User { get; set; }
}
