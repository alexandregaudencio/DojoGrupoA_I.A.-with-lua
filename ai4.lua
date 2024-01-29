-- Defina um nomr com até 6 caracteres (sem acentos ou cedilha)
name = "DaniH"
CharacterBehaviour = nil;



 function Update() 
    if Souls() == 0 then
       
        SetNearPlayerDestination()
        Attack()

        if IsNear() == true then

        end  


    end



    if Souls() > 0 then
        ReturnToBase()
    end



end


function IsNear() 
    return CharacterBehaviour.playerAgent.remainingDistance <= CharacterBehaviour.playerAgent.stoppingDistance

end

 function Souls() 

    return CharacterBehaviour.playerScript.Souls;

 end


