import React from 'react';
import InputMask from 'react-input-mask';

import '../assets/CSS/cadastro_empresa.css'


const onlyNumbers = (str) => str.replace(/[^0-9]/g, '');

const MaskedInput = ({ value, onChange, name, mask }) => {
    function handleChange(event) {
        onChange({
            ...event,
            target: {
                ...event.target,
                name,
                value: onlyNumbers(event.target.value)
            }
        });
    }

    function buscarcep(evento) {
        
    }

    return (
        <InputMask
            className="input-cadastro-usuario"
            name={name}
            mask={mask}
            value={value}
            onChange={handleChange}
        />
    );
};

export default MaskedInput;