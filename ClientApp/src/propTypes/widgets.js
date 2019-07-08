import PropTypes from 'prop-types';

export const widgetPropType = PropTypes.shape({
  id: PropTypes.number,
  name: PropTypes.string.isRequired,
  color: PropTypes.string.isRequired,
  quantity: PropTypes.number.isRequired,
});

export const widgetsPropType = PropTypes.arrayOf(widgetPropType);