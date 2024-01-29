name = "GYRU"
CharacterBehaviour = nil;

id = 2

 function Update() 
    SetNearPlayerDestination()
    
    Attack()  

    if Souls() ==1 then 
        ReturnToBase()
      end
      


end




 function Souls() 

   return CharacterBehaviour.playerScript.Souls;
 end



