-- Defina um nome com até 6 caracteres (sem acentos ou cedilha)
name = "Claudio"
CharacterBehaviour = nil;



 function Update() 

    Attack()

    if Souls() < 3 then
       
        SetNearPlayerDestination()


    end



    if Souls() >= 3 then
        ReturnToBase()
    end



end


function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance+2)

end

 function Souls() 

    return CharacterBehaviour.playerScript.Souls;

 end

