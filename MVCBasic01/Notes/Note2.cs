namespace MVCBasic01.Notes
{
    public class Note2
    {
        // every contlrollar have a folder in views folder contain views for him
        //view has the same name of action
        //scafold generate code in view (templet)
        // if when you creat view found error then you have error in code not in creating view
        //view extention is cshtml so you can write c# and html
        //if you want to wrirte c# in view one line write @ more than @{} whithout space
        // we can download bootstrap libirary or take link online(not preferd)

        //when you send request the response is html file and bootstrap libirary
        //note if the page have a lot of picture you send more than request for each image one request
        //to reduce nember of request we use bundel (compress more file in one)
        //if the responce return more than one file like html + bootstrap
        //bootstrap file is static file in WWWroot so to responce it 
        // request must pass over middleware cooled usestaticfile



    }
}
