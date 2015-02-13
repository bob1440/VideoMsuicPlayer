<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayOneMedia.aspx.cs" Inherits="WebApplication1.PlayOneMedia" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
        <script type="text/javascript" src="/scripts/jwplayer.js" ></script> 
    <script type="text/javascript">    jwplayer.key = "D2fUSHtOIKVhXa4yOZCKLpZUooZH1aEfI/akxw==";</script>
</head>
<body>
    <form id="form1" runat="server">
  
    <div id="myElement">Loading the player ...</div> 
    <script type="text/javascript">
        jwplayer("myElement").setup({
       flashplayer: "/player/jwplayer.flash.swf",
        file: "<%=PlayFile %>",
      // playlist: "/music/test.rss",
        height: 600,
        width: 960,
        type: 'mp4',
        provider:"video"
        
    }); 
</script>

<video width="320" height="240" controls>
 
     <source src="<%=PlayFile %>" type="video/mp4">
 
Your browser does not support the video tag.
</video>

    </form>
</body>
</html>
