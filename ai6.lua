-- Defina um nomr com até 6 caracteres (sem acentos ou cedilha)
name = "George"
CharacterBehaviour = nil;



 function Update() 
    if Souls() <= 1 then
       
        SetNearPlayerDestination()


        if IsNear() == true then
            Attack()
        end  


    end



    if Souls() > 0 then
        ReturnToBase()

	if IsNear() == true then
            Attack()
        end  

    end



end


function IsNear() 
    return (CharacterBehaviour.playerAgent.remainingDistance >= CharacterBehaviour.playerAgent.stoppingDistance+2)

end

 function Souls() 

    return CharacterBehaviour.playerScript.Souls;

 end
