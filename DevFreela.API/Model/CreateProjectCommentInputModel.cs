﻿namespace DevFreela.API.Model;

public class CreateProjectCommentInputModel
{
    public string Content { get; set; } = string.Empty;
    public int IdProject { get; set; }
    public int IdUser { get; set; }
}
