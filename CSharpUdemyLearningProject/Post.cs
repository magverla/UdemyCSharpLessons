using System;

public class Post
{
	private static int currentPostID;
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string SendByUserName { get; set; }
    protected bool IsPublic { get; set; }
    
    public Post(int iD = 0, string title = "Mein erster Post", string sendByUserName = "Ich", bool isPublic = true)
    {
        ID = GetNextID();
        Title = title;
        SendByUserName = sendByUserName;
        IsPublic = isPublic;
    }

    protected int GetNextID()
    {
        return ++currentPostID;
    }

    public void Update(string title, bool isPublic)
    {
        this.Title = title;
        this.IsPublic = isPublic;
    }

}
